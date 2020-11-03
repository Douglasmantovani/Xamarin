USE Jogos;

USE master;

INSERT INTO TipoUsuario(NomeTipoUsuario)VALUES
('Administrador'),('Comum')

INSERT INTO Usuario(Email,Senha,Nome,idTipoUsuario)VALUES
('Dougrinhas','123123','Douglas',1)

INSERT INTO Jogo(TituloJogo,Descricao,DataLan,Valor,Caminho)VALUES
('Red Dead Redemption II','Red Dead Redemption II é um jogo eletrônico de ação-aventura western desenvolvido pela Rockstar Studios','20-10-2018',250.00,'https://3er1viui9wo30pkxh1v2nh4w-wpengine.netdna-ssl.com/wp-content/uploads/prod/sites/42/2020/04/RDR_XBOX_1920X1080-WIRE-5ea198f09b883-960x640.jpg'),
('The Last of Us ParT II','The Last of Us Part II é um jogo eletrônico de ação-aventura e sobrevivência desenvolvido pela Naughty Dog e publicado pela Sony Interactive Entertainment. É uma sequência de The Last of Us','20-10-2020',250.00,'http://www.suacidade.com/sites/default/files/2020/The%20last%20Of%20Us%202%20Foto.Naughty%20Dog%20%28Facebook%29._1.jpg'),
('Final Fantasy VII Remake','Final Fantasy VII Remake é um jogo eletrônico de RPG de ação desenvolvido e publicado pela Square Enix.','20-10-2020',200,'https://images-na.ssl-images-amazon.com/images/I/51NUSDR6DQL._SX331_BO1,204,203,200_.jpg'),
('The Witcher 3','The Witcher 3: Wild Hunt é um jogo eletrônico de ação do subgênero RPG desenvolvido pela CD Projekt RED','20-10-2020',120.00,'https://upload.wikimedia.org/wikipedia/pt/0/06/TW3_Wild_Hunt.png'),
('Dragon Age Inquisition','Inquisition é um jogo eletrônico de RPG de ação desenvolvido pela BioWare e publicado pela Electronic Arts','20-10-2020',100.00,'https://upload.wikimedia.org/wikipedia/pt/5/58/Dragon_Age_Inquisition_capa.png'),
('Assasin s Creed Black Flag IV','Assassin''s Creed IV: Black Flag é um videojogo de ação-aventura desenvolvido pela Ubisoft','20-10-2020',78.00,'https://upload.wikimedia.org/wikipedia/pt/c/ca/Assassins_Creed_4_Black_Flag_capa.png'),
('Metal Gear Solid V The Phantom Pain','Metal Gear Solid V: The Phantom Pain é um jogo eletrônico de ação-aventura furtiva desenvolvido pela Kojima Productions, co-produzido pela Kojima Productions Los Angeles e realizado, desenhado, co-produzido e co-escrito por Hideo Kojima.','20-10-2020',50.99,'https://upload.wikimedia.org/wikipedia/pt/1/19/MGS5_TPP.jpg'),
('The Last Of Us','The Last of Us é um jogo eletrônico de ação-aventura e survival horror desenvolvido pela Naughty Dog e publicado pela Sony Computer Entertainment. Ele foi lançado exclusivamente para PlayStation 3 em 14 de junho de 2013. É o primeiro jogo da franquia The Last of Us.','20-10-2020',79.99,'http://1.bp.blogspot.com/-rKEVwHl5X5s/Ud3X3hWnbyI/AAAAAAAADic/u0BaaqqLoxo/s1600/The-Last-of-Us-key-art.jpg')

