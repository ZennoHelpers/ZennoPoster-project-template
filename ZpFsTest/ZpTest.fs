namespace ZpTest

open System
open ZennoLab.CommandCenter
open ZennoLab.InterfacesLibrary.ProjectModel

type public Main() =
    interface IZennoCustomCode with
        member this.ExecuteCode(instance: Instance, project: IZennoPosterProjectModel): int =
            project.SendInfoToLog "Test"
            0

    interface IZennoCustomEndCode with
        member this.GoodEnd(instance: Instance, project: IZennoPosterProjectModel): unit = ()
        member this.BadEnd(instance: Instance, project: IZennoPosterProjectModel): unit = ()
