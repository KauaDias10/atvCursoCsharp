// SKU = Unidade de Manutenção de Estoque (Stock Keeping Unit)
// Formato do valor SKU: <produto #>-<código de 2 letras da cor>-<código do tamanho>
string sku = "01-MN-L";

string[] produto = sku.Split('-');

string tipo = ""; // type
string cor = ""; // color
string tamanho = ""; // size

switch (produto[0])
{
    case "01":
        tipo = "Moletom"; // Sweat shirt
        break;
    case "02":
        tipo = "Camiseta"; // T-Shirt
        break;
    case "03":
        tipo = "Calça de moletom"; // Sweat pants
        break;
    default:
        tipo = "Outro"; // Other
        break;
}

switch (produto[1])
{
    case "BL":
        cor = "Preto"; // Black
        break;
    case "MN":
        cor = "Vinho"; // Maroon
        break;
    default:
        cor = "Branco"; // White
        break;
}

switch (produto[2])
{
    case "S":
        tamanho = "Pequeno"; // Small
        break;
    case "M":
        tamanho = "Médio"; // Medium
        break;
    case "L":
        tamanho = "Grande"; // Large
        break;
    default:
        tamanho = "Outro"; // Other
        break;
}

Console.WriteLine($"Produto: {tamanho} {cor} {tipo}");