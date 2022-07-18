export class Usuario{
    constructor(
        public DocumentId: bigint,
        public Nombres: string,
        public Apellidos: string,
        public Email:string,
        public Password:string,
        public Rol:string,
        public FechRegistro:string,
        public CodValid:string,
        public Celular:bigint
    ){}
}