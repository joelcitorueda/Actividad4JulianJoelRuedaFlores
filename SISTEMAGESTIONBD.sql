-- Crear la base de datos
CREATE DATABASE SISTEMAGESTION;
GO


CREATE TABLE CLIENTE (
    IDCLIENTE INT IDENTITY(1,1) PRIMARY KEY,
    NOMBRE NVARCHAR(50),
    APELLIDO NVARCHAR(50),
    CORREOELECTRONICO NVARCHAR(100),
    TELEFONO NVARCHAR(20),
    DIRECCION NVARCHAR(255)
);
GO

INSERT INTO Cliente (Nombre, Apellido, CorreoElectronico, Telefono, Direccion) 
VALUES 
('Juan', 'Perez', 'juan@example.com', '+591 555-1234', 'Calle 123, Ciudad'),
('Maria', 'Rodriguez', 'maria@example.com', '+591 555-5678', 'Avenida 456, Pueblo'),
('Pedro', 'Gomez', 'pedro@example.com', '+591 555-9012', 'Plaza 789, Villa'),
('Ana', 'Fernandez', 'ana@example.com', '+591 555-3456', 'Camino 234, Aldea'),
('Luis', 'Martinez', 'luis@example.com', '+591 555-7890', 'Carrera 567, Poblado'),
('Laura', 'Sanchez', 'laura@example.com', '+591 555-2345', 'Pasaje 890, Ciudad'),
('Carlos', 'Lopez', 'carlos@example.com', '+591 555-6789', 'Autopista 123, Pueblo'),
('Sofia', 'Diaz', 'sofia@example.com', '+591 555-0123', 'Callejon 456, Villa'),
('Diego', 'Martin', 'diego@example.com', '+591 555-4567', 'Plaza 789, Ciudad'),
('Marta', 'Jimenez', 'marta@example.com', '+591 555-8901', 'Avenida 234, Poblado'),
('Pablo', 'Ruiz', 'pablo@example.com', '+591 555-2345', 'Camino 567, Pueblo'),
('Lucia', 'Perez', 'lucia@example.com', '+591 555-6789', 'Carrera 890, Aldea'),
('Jorge', 'Gonzalez', 'jorge@example.com', '+591 555-0123', 'Pasaje 123, Ciudad'),
('Carmen', 'Hernandez', 'carmen@example.com', '+591 555-4567', 'Autopista 456, Villa'),
('Ana', 'Ramirez', 'ana.ramirez@example.com', '+591 555-8901', 'Callejon 789, Poblado');



