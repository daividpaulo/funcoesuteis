  	//Expressão regular que aceita somente números inteiros

        string numero = @"^\d+$";     //ou      
		string numero2 = @"^[0-9]+$";

	//Expressão regular que aceita números reais

        string numeroReal = @"^\d+?(.|,\d+)$";      //ou       
		string numeroReal2 = @"^[0-9]+?(.|,[0-9]+)$";


	//Expressao regular que valida email

        string email = @"^([\w\-]+\.)*[\w\- ]+@([\w\- ]+\.)+([\w\-]{2,3})$";


	//Expressão regular que valida telefone

        string telefone = @"^\d{2}-\d{4}-\d{4}$";    //ou
        string telefone2 = @"^[0-9]{2}-[0-9]{4}-[0-9]{4}$";

	//Expressao regular que valida cpf

        string cpf = @"^\d{3}\.?\d{3}\.?\d{3}\-?\d{2}$";

	
	//Expressao regular que valida cnpj

        string cnpj = @"^\d{3}.?\d{3}.?\d{3}/?\d{3}-?\d{2}$";

	
	//Expressao regular que valida data formato dd/mm/yyyy

        string data = @"^((0[1-9]|[12]\d)\/(0[1-9]|1[0-2])|30\/(0[13-9]|1[0-2])|31\/(0[13578]|1[02]))\/\d{4}$";

	//Expressao regular que valida cep

        string cep = @"^\d{5}\-?\d{3}$";


	//Expressao regular que valida url

        string url = @"^((http)|(https)|(ftp)):\/\/([\- \w]+\.)+\w{2,3}(\/ [%\-\w]+(\.\w{2,})?)*$";

	//Expressao regular que valida ip

        string ip = @"^\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b$";


	//Expressao regular que valida nomes

        string nome = @"^([\'\.\^\~\´\`\\áÁ\\àÀ\\ãÃ\\âÂ\\éÉ\\èÈ\\êÊ\\íÍ\\ìÌ\\óÓ\\òÒ\\õÕ\\ôÔ\\úÚ\\ùÙ\\çÇaA-zZ]+)+((\s[\'\.\^\~\´\`\\áÁ\\àÀ\\ãÃ\\âÂ\\éÉ\\èÈ\\êÊ\\íÍ\\ìÌ\\óÓ\\òÒ\\õÕ\\ôÔ\\úÚ\\ùÙ\\çÇaA-zZ]+)+)?$";

        //ou

        string nome2 = @"^[aA-zZ]+((\s[aA-zZ]+)+)?$";


















 



