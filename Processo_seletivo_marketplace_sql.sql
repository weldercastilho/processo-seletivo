create database marketplace;
use marketplace;
-- drop database marketplace;
-- select * from loj_lojas inner join end_lojaEndereco using(loj_id) inner join rsp_responsavel using(loj_id);
-- select * from pdt_produto;
-- select * from rsp_responsavel;
create table loj_lojas(
loj_id int primary key auto_increment,
loj_nome text,
loj_cnpj varchar (18),
loj_razsocial text
);

create table end_lojaEndereco(
end_id int primary key auto_increment,
end_cidade text,
end_estado varchar(2),
end_bairro text,
end_rua text, 
end_numero int,
end_complemento text,
loj_id int not null, foreign key (loj_id) references loj_lojas(loj_id)
);

create table rsp_responsavel(
rsp_id int primary key auto_increment,
rsp_telefone text,
rsp_nome text,
rsp_cargo text,
loj_id int not null, foreign key (loj_id) references loj_lojas(loj_id)
);

create table pdt_produto(
pdt_id int primary key auto_increment,
pdt_nome text,
pdt_preco double,
pdd_descricao text,
loj_id int not null, foreign key (loj_id) references loj_lojas(loj_id)
);
-- insert into pdt_produto(pdt_nome, pdt_preco, pdt_descricao, loj_id)values('lapis', 0.50, 'lapis de desenho', 1);
-- call cad_cadastro('welder', '00.000.000/0000-00', 'welder.inc', 'poá', 'sp', 'santa helena', 'muzambinho', 25, 'nancy', null, '46342016', 'welder castilho', 'diretor');

delimiter $$
create procedure cad_cadastro(
in vloj_nome text,
in vloj_cnpj varchar (18),
in vloj_razsocial text,
in vend_cidade text,
in vend_estado varchar(2),
in vend_bairro text,
in vend_rua text, 
in vend_numero int,
in vend_complemento text,
in vloj_id int,
in vrsp_telefone text,
in vrsp_nome text,
in vrsp_cargo text
)
begin
 
 declare contarID int;
 declare excessao smallint default 0;
 declare continue handler for sqlexception set excessao = 1;
 
 start transaction;
 
select count(*) into contarID from loj_lojas where loj_id = vloj_id;
if(contarID <= 0) then 
   set excessao := 0;
  insert into loj_lojas(loj_nome, loj_cnpj, loj_razsocial)values(vloj_nome, vloj_cnpj, vloj_razsocial);
   if(excessao = 0) then
	set vloj_id = (select loj_id from loj_lojas where loj_nome = vloj_nome); 
       insert into end_lojaEndereco(end_cidade, end_estado, end_bairro, end_rua, end_numero, end_complemento, loj_id) values (vend_cidade, vend_estado, vend_bairro, vend_rua, vend_numero, vend_complemento, vloj_id);
       if (excessao = 0) then
		insert into rsp_responsavel(rsp_telefone, rsp_nome, rsp_cargo, loj_id)values(vrsp_telefone, vrsp_nome, vrsp_cargo, vloj_id);
        if (excessao = 0)then
			select '-0' as msg; -- sucesso
            commit;
        else
           select '-4' as msg; -- erro ao inserir responsavel
           rollback;
           end if;
       else
           select '-3' as msg; -- erro ao inserir cliente
           rollback;
       end if;
   else
	   select '-2' as msg; -- erro ao inserir pessoa
       rollback;
   end if;
else
   select '-1' as msg; -- cpf ja cadastrado
 
end if;
end $$ 
delimiter ; 