# Redream

(Kind of) Realtime Stable Diffusion from a screen area using [Automatic1111](https://github.com/AUTOMATIC1111/stable-diffusion-webui)'s API.

## Requirement
- Windows OS
- [Automatic1111 stable-diffusion-webui](https://github.com/AUTOMATIC1111/stable-diffusion-webui)   
To run web ui with ```--api``` commandline argument
example in your "webui-user.bat": 
```
set COMMANDLINE_ARGS=--api
```
- [.NET 6.0 Framework](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [Redream 1.0 Compiled execuable](https://github.com/Fictiverse/Redream/releases/download/1.0/Fictiverse_Redream_1.0.7z)   
Or compile this ```c#``` repo with [Visual Studio](https://visualstudio.microsoft.com/en/downloads/)

## How to use

![image](https://user-images.githubusercontent.com/111762798/207283950-3de127e8-575a-4012-98b9-73c9258f4fe7.png)

- Start to press ![image](https://user-images.githubusercontent.com/111762798/207306165-315287c6-e337-46fa-9d80-19c4eb782226.png)   
Place the ```Capture area``` where you want and lock the position with ```left click```.  


- ![image](https://user-images.githubusercontent.com/111762798/207306554-a15944a1-3acd-41c0-8054-b2ab6a441265.png) ```Click``` to Start/Stop.
- ![image](https://user-images.githubusercontent.com/111762798/207307399-d24b97ca-4ef0-4fc3-b62a-290e82c3acc8.png) ```Click``` to save every generated frames
- ![image](https://user-images.githubusercontent.com/111762798/207307617-5af3735b-eda3-48dc-b426-f93db18809a6.png) ```Click``` to change aspect ratio

Changing options :
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
![image](https://user-images.githubusercontent.com/111762798/207310573-321321d8-d735-463b-8ec3-28a8bb53ffd8.png) ```Click``` to interrogate the last captured image


## Contact

[Discord](https://discord.gg/UYgRnhj8PR) - [Twitter](https://twitter.com/Fictiverse)
