using Microsoft.AspNetCore.Components;

namespace Blazor_Tarefas.Pages;

public class CodeBehindBase : ComponentBase
{
    protected int currentCount = 0;
    protected void IncrementCount()
    {
        currentCount++;
    }
}