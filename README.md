# Fictiverse : Redream

(Kind of) Realtime Stable Diffusion from a screen area using [Automatic1111](https://github.com/AUTOMATIC1111/stable-diffusion-webui)'s API.
![screen](https://github.com/Fictiverse/Redream/assets/111762798/b408591d-3150-48bb-8f22-9d054726389c)


## Requirement
- Windows OS
- [Automatic1111 stable-diffusion-webui](https://github.com/AUTOMATIC1111/stable-diffusion-webui)   
Make sure```--xformers``` and ```--api``` commandline arguments are set in your "webui-user.bat":   
```set COMMANDLINE_ARGS=--xformers --api``` 
- [ControlNet Extension](https://github.com/Mikubill/sd-webui-controlnet)
- [.NET 6.0 Framework](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- Last [Redream](https://github.com/Fictiverse/Redream/releases/latest) Release       
Or compile this repo with [Visual Studio](https://visualstudio.microsoft.com/en/downloads/)

https://user-images.githubusercontent.com/111762798/208230356-3e1272a1-60f9-4a12-9996-ea8431cd0017.mp4


## How to use
- First, start **Automatic1111 stable-diffusion-webui** and wait until it is ready.   

Starting with Redream :   
![image](https://user-images.githubusercontent.com/111762798/207682985-39ae0ce5-d2bf-4067-b136-5a2dd5fdaf6b.png)

- Start to press ![image](https://user-images.githubusercontent.com/111762798/207306165-315287c6-e337-46fa-9d80-19c4eb782226.png)   
Place the ```Capture area``` where you want.  
`Right click` to move, 
`Left click` to paint mask, 
`Middle click` to erase mask, 
`Mouse Scroll` to change brush size,
`Right click + Mouse  Scroll` to resize capture zone   

- ![image](https://user-images.githubusercontent.com/111762798/207306554-a15944a1-3acd-41c0-8054-b2ab6a441265.png) ```Click``` to Start/Stop.
- ![image](https://user-images.githubusercontent.com/111762798/207307399-d24b97ca-4ef0-4fc3-b62a-290e82c3acc8.png) ```Click``` to save every generated frames
- ![image](https://user-images.githubusercontent.com/111762798/207307617-5af3735b-eda3-48dc-b426-f93db18809a6.png) ```Click``` to change aspect ratio

Changing diffusion settings :
- ![image](https://user-images.githubusercontent.com/111762798/207307725-a0c2fea1-3f04-4e5d-8504-1004f610be72.png) ```Click/MouseScroll``` to change the seed value (-1 for random)
- ![image](https://user-images.githubusercontent.com/111762798/207308468-fd1085df-11ef-4692-8a19-36ee129bbfdf.png) ```Click/MouseScroll``` to change the steps
- ![image](https://user-images.githubusercontent.com/111762798/207308656-348a6d65-0014-4b49-94ed-d28521246200.png) ```Click/MouseScroll``` to change the denoising strength
- ![image](https://user-images.githubusercontent.com/111762798/207308818-78c084e5-f489-42c4-ab21-f2e7c56033b5.png) ```Click/MouseScroll``` to change the cfg scale

Saving presets :
- ![image](https://user-images.githubusercontent.com/111762798/207309228-04635108-dbd7-40af-8913-f6848a54d2be.png)   
```Click``` to enable Fav mod   
- ![image](https://user-images.githubusercontent.com/111762798/207309404-749e0a8d-0fde-40d8-892c-2ea928643cf8.png)   
Presets will start blinking
- ![image](https://user-images.githubusercontent.com/111762798/207309847-1ef2322a-bee2-4c79-82bf-00f161f55746.png)   
```Click``` to save the current prompt into the selected slot number.

Prompt:   
- ![image](https://user-images.githubusercontent.com/111762798/207310573-321321d8-d735-463b-8ec3-28a8bb53ffd8.png) ```Click``` to interrogate the last captured image

Licence:MIT

## Contact
[Paypal](https://www.paypal.com/donate/?hosted_button_id=MSXYHF2E7YXZG)   
[Discord](https://discord.gg/UYgRnhj8PR) - [Twitter](https://twitter.com/Fictiverse)
