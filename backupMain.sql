PGDMP     
    .            	    y            BD    13.2    13.2 7    ?           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            ?           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            ?           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            ?           1262    24815    BD    DATABASE     a   CREATE DATABASE "BD" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Russian_Russia.1251';
    DROP DATABASE "BD";
                postgres    false            ?            1255    33175    del_sum(integer)    FUNCTION     ?   CREATE FUNCTION public.del_sum(_id integer) RETURNS TABLE(qw bigint)
    LANGUAGE plpgsql
    AS $$

 begin
  return query
	SELECT sum(quant) AS qw
	FROM deliveries
	where p_id = _id;
 end
 
$$;
 +   DROP FUNCTION public.del_sum(_id integer);
       public          postgres    false            ?            1255    33004    dl_delete(integer)    FUNCTION     ?   CREATE FUNCTION public.dl_delete(_id integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$

begin
 delete from deliveries
 where del_id = _id;
 if found then --deleted successfully
  return 1;
 else
  return 0;
 end if;
end

$$;
 -   DROP FUNCTION public.dl_delete(_id integer);
       public          postgres    false            ?            1255    33003 *   dl_insert(integer, integer, integer, date)    FUNCTION     U  CREATE FUNCTION public.dl_insert(u_id1 integer, p_id1 integer, quant1 integer, datesl1 date) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
 insert into "deliveries"(u_id, p_id, quant, datedel)
 values(u_id1, p_id1, quant1, datesl1);
 if found then --inserted successfully
  return 1;
 else return 0; -- inserted fail
 end if;
end
$$;
 \   DROP FUNCTION public.dl_insert(u_id1 integer, p_id1 integer, quant1 integer, datesl1 date);
       public          postgres    false            ?            1255    33002    dl_select()    FUNCTION     ?  CREATE FUNCTION public.dl_select() RETURNS TABLE(_id integer, idu integer, "Имя пользователя" text, idp integer, "Продукция" text, "Количество" integer, "Дата поставки" date)
    LANGUAGE plpgsql
    AS $$
 begin
  return query
 select del_id, u_id, ФИО, p_id, наименование, deliveries.quant, datedel from users, product, deliveries 
 where u_id = us_id and pr_id = p_id
 order by deliveries.del_id;
 end
$$;
 "   DROP FUNCTION public.dl_select();
       public          postgres    false            ?            1255    33005 3   dl_update(integer, integer, integer, integer, date)    FUNCTION     f  CREATE FUNCTION public.dl_update(_id integer, _idu integer, _idp integer, qw integer, dates date) RETURNS integer
    LANGUAGE plpgsql
    AS $$

 begin
  update deliveries
 set 
u_id =_idu,
p_id = _idp, 
quant = qw , 
datedel = dates 
where del_id = _id;
 if found then --updated successfully
  return 1;
 else --updated fail
  return 0;
 end if;
 end

$$;
 a   DROP FUNCTION public.dl_update(_id integer, _idu integer, _idp integer, qw integer, dates date);
       public          postgres    false            ?            1255    24860    pr_delete(integer)    FUNCTION     ?   CREATE FUNCTION public.pr_delete(_id integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
 delete from product
 where pr_id = _id;
 if found then --deleted successfully
  return 1;
 else
  return 0;
 end if;
end
$$;
 -   DROP FUNCTION public.pr_delete(_id integer);
       public          postgres    false            ?            1255    24863    pr_insert(text, integer)    FUNCTION       CREATE FUNCTION public.pr_insert(nm text, qw integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
 insert into product(наименование, qua)
 values(nm, qw);
 if found then --inserted successfully
  return 1;
 else return 0; -- inserted fail
 end if;
end
$$;
 5   DROP FUNCTION public.pr_insert(nm text, qw integer);
       public          postgres    false            ?            1255    33008    pr_select()    FUNCTION     ?   CREATE FUNCTION public.pr_select() RETURNS TABLE(_id integer, "Наименование" text, "Количество" integer)
    LANGUAGE plpgsql
    AS $$


  begin
  return query
 select * from product order by pr_id;

 end
 
$$;
 "   DROP FUNCTION public.pr_select();
       public          postgres    false            ?            1255    24859 !   pr_update(integer, text, integer)    FUNCTION     9  CREATE FUNCTION public.pr_update(_id integer, name text, qw integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$

 begin
  update product
 set 
наименование = name,
 qua = qw 
where pr_id = _id;
 if found then --updated successfully
  return 1;
 else --updated fail
  return 0;
 end if;
 end
 
$$;
 D   DROP FUNCTION public.pr_update(_id integer, name text, qw integer);
       public          postgres    false            ?            1255    33000    sl_delete(integer)    FUNCTION     ?   CREATE FUNCTION public.sl_delete(_id integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
 delete from sales
 where sl_id = _id;
 if found then --deleted successfully
  return 1;
 else
  return 0;
 end if;
end
$$;
 -   DROP FUNCTION public.sl_delete(_id integer);
       public          postgres    false            ?            1255    24936 *   sl_insert(integer, integer, integer, date)    FUNCTION     Q  CREATE FUNCTION public.sl_insert(u_id1 integer, p_id1 integer, quant1 integer, datesl1 date) RETURNS integer
    LANGUAGE plpgsql
    AS $$

begin
 insert into "sales"(u_id, p_id, quant, datesl)
 values(u_id1, p_id1, quant1, datesl1);
 if found then --inserted successfully
  return 1;
 else return 0; -- inserted fail
 end if;
end

$$;
 \   DROP FUNCTION public.sl_insert(u_id1 integer, p_id1 integer, quant1 integer, datesl1 date);
       public          postgres    false            ?            1255    24935    sl_select()    FUNCTION     ?  CREATE FUNCTION public.sl_select() RETURNS TABLE(id integer, user_id integer, "Имя пользователя" text, prod_id integer, "Продукция" text, "Количество" integer, "Дата продажи" date)
    LANGUAGE plpgsql
    AS $$

 begin
  return query
 select sl_id, u_id, ФИО, p_id, наименование, sales.quant, datesl from "users","product", "sales" 
 where u_id = us_id and pr_id = p_id
 order by sl_id;
 end
 
$$;
 "   DROP FUNCTION public.sl_select();
       public          postgres    false            ?            1255    33174    sl_sum(integer)    FUNCTION     ?   CREATE FUNCTION public.sl_sum(_id integer) RETURNS TABLE(qw bigint)
    LANGUAGE plpgsql
    AS $$

 begin
  return query
	SELECT sum(quant) AS qw
	FROM sales
	where p_id = _id;
 end
 
$$;
 *   DROP FUNCTION public.sl_sum(_id integer);
       public          postgres    false            ?            1255    32999 3   sl_update(integer, integer, integer, integer, date)    FUNCTION     _  CREATE FUNCTION public.sl_update(_id integer, _idu integer, _idp integer, qw integer, dates date) RETURNS integer
    LANGUAGE plpgsql
    AS $$

 begin
  update sales
 set 
u_id =_idu,
p_id = _idp, 
quant = qw , 
datesl = dates 
where sl_id = _id;
 if found then --updated successfully
  return 1;
 else --updated fail
  return 0;
 end if;
 end

$$;
 a   DROP FUNCTION public.sl_update(_id integer, _idu integer, _idp integer, qw integer, dates date);
       public          postgres    false            ?            1255    33086    statistic(date, date)    FUNCTION     +  CREATE FUNCTION public.statistic(dt1 date, dt2 date) RETURNS TABLE(_id integer, qw bigint)
    LANGUAGE plpgsql
    AS $$

 begin
  return query
	SELECT p_id, sum(quant) AS qw
	FROM sales
	INNER JOIN product on sales.p_id = product.pr_id
	where datesl between dt1 and dt2
	GROUP BY p_id;
 end
 
$$;
 4   DROP FUNCTION public.statistic(dt1 date, dt2 date);
       public          postgres    false            ?            1255    24831    us_delete(integer)    FUNCTION     ?   CREATE FUNCTION public.us_delete(_id integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
 delete from users
 where us_id = _id;
 if found then --deleted successfully
  return 1;
 else
  return 0;
 end if;
end
$$;
 -   DROP FUNCTION public.us_delete(_id integer);
       public          postgres    false            ?            1255    24828    us_insert(text)    FUNCTION     ?   CREATE FUNCTION public.us_insert(fio text) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
 insert into users(ФИО)
 values(FIO);
 if found then --inserted successfully
  return 1;
 else return 0; -- inserted fail
 end if;
end
$$;
 *   DROP FUNCTION public.us_insert(fio text);
       public          postgres    false            ?            1255    33011    us_select()    FUNCTION     ?   CREATE FUNCTION public.us_select() RETURNS TABLE(_id integer, "Имя пользователя" text)
    LANGUAGE plpgsql
    AS $$

  begin
  return query
 select * from users order by us_id;
 end

$$;
 "   DROP FUNCTION public.us_select();
       public          postgres    false            ?            1255    24830    us_update(integer, text)    FUNCTION     
  CREATE FUNCTION public.us_update(_id integer, fio text) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
  update users
 set 
  ФИО = FIO
 where us_id = _id;
 if found then --updated successfully
  return 1;
 else --updated fail
  return 0;
 end if;
 end
$$;
 7   DROP FUNCTION public.us_update(_id integer, fio text);
       public          postgres    false            ?            1259    33054 
   deliveries    TABLE     ?   CREATE TABLE public.deliveries (
    del_id integer NOT NULL,
    u_id integer NOT NULL,
    p_id integer NOT NULL,
    quant integer NOT NULL,
    datedel date NOT NULL
);
    DROP TABLE public.deliveries;
       public         heap    postgres    false            ?            1259    33052    deliveries_del_id_seq    SEQUENCE     ?   CREATE SEQUENCE public.deliveries_del_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public.deliveries_del_id_seq;
       public          postgres    false    207            ?           0    0    deliveries_del_id_seq    SEQUENCE OWNED BY     O   ALTER SEQUENCE public.deliveries_del_id_seq OWNED BY public.deliveries.del_id;
          public          postgres    false    206            ?            1259    33014    product    TABLE     r   CREATE TABLE public.product (
    pr_id integer NOT NULL,
    "наименование" text,
    qua integer
);
    DROP TABLE public.product;
       public         heap    postgres    false            ?            1259    33012    product_pr_id_seq    SEQUENCE     ?   CREATE SEQUENCE public.product_pr_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 (   DROP SEQUENCE public.product_pr_id_seq;
       public          postgres    false    201            ?           0    0    product_pr_id_seq    SEQUENCE OWNED BY     G   ALTER SEQUENCE public.product_pr_id_seq OWNED BY public.product.pr_id;
          public          postgres    false    200            ?            1259    33036    sales    TABLE     ?   CREATE TABLE public.sales (
    sl_id integer NOT NULL,
    u_id integer NOT NULL,
    p_id integer NOT NULL,
    quant integer NOT NULL,
    datesl date NOT NULL
);
    DROP TABLE public.sales;
       public         heap    postgres    false            ?            1259    33034    sales_sl_id_seq    SEQUENCE     ?   CREATE SEQUENCE public.sales_sl_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public.sales_sl_id_seq;
       public          postgres    false    205            ?           0    0    sales_sl_id_seq    SEQUENCE OWNED BY     C   ALTER SEQUENCE public.sales_sl_id_seq OWNED BY public.sales.sl_id;
          public          postgres    false    204            ?            1259    33025    users    TABLE     M   CREATE TABLE public.users (
    us_id integer NOT NULL,
    "ФИО" text
);
    DROP TABLE public.users;
       public         heap    postgres    false            ?            1259    33023    users_us_id_seq    SEQUENCE     ?   CREATE SEQUENCE public.users_us_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public.users_us_id_seq;
       public          postgres    false    203            ?           0    0    users_us_id_seq    SEQUENCE OWNED BY     C   ALTER SEQUENCE public.users_us_id_seq OWNED BY public.users.us_id;
          public          postgres    false    202            L           2604    33093    deliveries del_id    DEFAULT     v   ALTER TABLE ONLY public.deliveries ALTER COLUMN del_id SET DEFAULT nextval('public.deliveries_del_id_seq'::regclass);
 @   ALTER TABLE public.deliveries ALTER COLUMN del_id DROP DEFAULT;
       public          postgres    false    206    207    207            I           2604    33094    product pr_id    DEFAULT     n   ALTER TABLE ONLY public.product ALTER COLUMN pr_id SET DEFAULT nextval('public.product_pr_id_seq'::regclass);
 <   ALTER TABLE public.product ALTER COLUMN pr_id DROP DEFAULT;
       public          postgres    false    201    200    201            K           2604    33095    sales sl_id    DEFAULT     j   ALTER TABLE ONLY public.sales ALTER COLUMN sl_id SET DEFAULT nextval('public.sales_sl_id_seq'::regclass);
 :   ALTER TABLE public.sales ALTER COLUMN sl_id DROP DEFAULT;
       public          postgres    false    205    204    205            J           2604    33096    users us_id    DEFAULT     j   ALTER TABLE ONLY public.users ALTER COLUMN us_id SET DEFAULT nextval('public.users_us_id_seq'::regclass);
 :   ALTER TABLE public.users ALTER COLUMN us_id DROP DEFAULT;
       public          postgres    false    203    202    203            ?          0    33054 
   deliveries 
   TABLE DATA           H   COPY public.deliveries (del_id, u_id, p_id, quant, datedel) FROM stdin;
    public          postgres    false    207   ?J       ?          0    33014    product 
   TABLE DATA           I   COPY public.product (pr_id, "наименование", qua) FROM stdin;
    public          postgres    false    201   ?J       ?          0    33036    sales 
   TABLE DATA           A   COPY public.sales (sl_id, u_id, p_id, quant, datesl) FROM stdin;
    public          postgres    false    205   ?J       ?          0    33025    users 
   TABLE DATA           0   COPY public.users (us_id, "ФИО") FROM stdin;
    public          postgres    false    203   ?J       ?           0    0    deliveries_del_id_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.deliveries_del_id_seq', 6, true);
          public          postgres    false    206            ?           0    0    product_pr_id_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.product_pr_id_seq', 6, true);
          public          postgres    false    200            ?           0    0    sales_sl_id_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.sales_sl_id_seq', 20, true);
          public          postgres    false    204            ?           0    0    users_us_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.users_us_id_seq', 6, true);
          public          postgres    false    202            T           2606    33059    deliveries deliveries_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.deliveries
    ADD CONSTRAINT deliveries_pkey PRIMARY KEY (del_id);
 D   ALTER TABLE ONLY public.deliveries DROP CONSTRAINT deliveries_pkey;
       public            postgres    false    207            N           2606    33022    product product_pkey 
   CONSTRAINT     U   ALTER TABLE ONLY public.product
    ADD CONSTRAINT product_pkey PRIMARY KEY (pr_id);
 >   ALTER TABLE ONLY public.product DROP CONSTRAINT product_pkey;
       public            postgres    false    201            R           2606    33041    sales sales_pkey 
   CONSTRAINT     Q   ALTER TABLE ONLY public.sales
    ADD CONSTRAINT sales_pkey PRIMARY KEY (sl_id);
 :   ALTER TABLE ONLY public.sales DROP CONSTRAINT sales_pkey;
       public            postgres    false    205            P           2606    33033    users users_pkey 
   CONSTRAINT     Q   ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (us_id);
 :   ALTER TABLE ONLY public.users DROP CONSTRAINT users_pkey;
       public            postgres    false    203            W           2606    33060    deliveries dl_pd    FK CONSTRAINT     ?   ALTER TABLE ONLY public.deliveries
    ADD CONSTRAINT dl_pd FOREIGN KEY (p_id) REFERENCES public.product(pr_id) ON DELETE SET DEFAULT NOT VALID;
 :   ALTER TABLE ONLY public.deliveries DROP CONSTRAINT dl_pd;
       public          postgres    false    201    207    2894            X           2606    33075    deliveries dl_us    FK CONSTRAINT     ?   ALTER TABLE ONLY public.deliveries
    ADD CONSTRAINT dl_us FOREIGN KEY (u_id) REFERENCES public.users(us_id) ON DELETE SET DEFAULT NOT VALID;
 :   ALTER TABLE ONLY public.deliveries DROP CONSTRAINT dl_us;
       public          postgres    false    2896    203    207            U           2606    33065    sales sl_pd    FK CONSTRAINT     ?   ALTER TABLE ONLY public.sales
    ADD CONSTRAINT sl_pd FOREIGN KEY (p_id) REFERENCES public.product(pr_id) ON DELETE SET DEFAULT NOT VALID;
 5   ALTER TABLE ONLY public.sales DROP CONSTRAINT sl_pd;
       public          postgres    false    201    205    2894            V           2606    33070    sales sl_us    FK CONSTRAINT     ?   ALTER TABLE ONLY public.sales
    ADD CONSTRAINT sl_us FOREIGN KEY (u_id) REFERENCES public.users(us_id) ON DELETE SET DEFAULT NOT VALID;
 5   ALTER TABLE ONLY public.sales DROP CONSTRAINT sl_us;
       public          postgres    false    2896    205    203            ?      x?????? ? ?      ?      x?????? ? ?      ?      x?????? ? ?      ?      x?????? ? ?     