namespace DI {
    class TypesLifeCycle {

        //Transient 
        //Transient lifetime services are created each time they`re requested from the service container. This lifetime works best for lightweight stateless services


        //Scoped
        //Scoped lifetimes services are created once per cliente request (connect) - One creation per request

        //Singleton
        //Created the first time they are requested (or when configureServices is run and an instance specified with service registration).

    }

    class FromServiceDI {
        //Quando nao eh possivel utilizar o construtor da classe para injetar dependencias, pode se usar o ˜fromServices`no metodo para a injecao.
        public void Index([FromServices]IclienteServices clienteServices)
        {
            clienteServices.AdicionarCliente(new Cliente());
        }
    }

}