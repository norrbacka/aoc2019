﻿module Day1

    let d = "82406;83106;120258;142695;50629;117793;81165;83442;70666;94355;64069;72830;88813;148762;90723;121206;57713;116892;82470;101686;83768;92160;91532;136997;142382;120050;81062;106227;112071;102275;54033;109059;91772;63320;81872;52925;92225;60053;110402;97125;87404;54970;66662;83979;88474;91361;69272;61559;56603;96324;66226;95278;105643;139141;116838;130717;97708;108371;73652;100518;98295;63127;50486;121157;109721;110874;124791;147116;127335;65889;76769;100596;79740;125860;120185;73861;97700;147169;106781;71891;64744;107113;59274;77680;101891;69848;98922;147825;128315;55221;119892;87492;75814;80350;131504;81095;57344;63765;143915;126768"

    let numbers = 
        d.Split ';'
        |> Array.toList
        |> List.map double

    let calcFuel (f : double) =
        System.Math.Floor(f / 3.0)-2.0

    let part1 () =
        numbers
        |> List.sumBy (fun f -> calcFuel f)

    let rec calculateTotalFuel m : double =
        match calcFuel m with
            | m when m <= 0.0 -> 0.0
            | m -> m + calculateTotalFuel m

    let part2 () =
        numbers
        |> List.sumBy calculateTotalFuel