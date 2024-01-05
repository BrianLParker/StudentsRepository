using Microsoft.AspNetCore.Components.Web;

namespace StudentsRepository.Client;

public static class CustomRenderModes
{
    public static InteractiveWebAssemblyRenderMode InteractiveWebAssemblyNoPreRender { get; } = new InteractiveWebAssemblyRenderMode(false);
}