using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatenation.Benchmarks;

[MemoryDiagnoser(true)]
//[SimpleJob(runtimeMoniker: RuntimeMoniker.Net60)]
//[SimpleJob(runtimeMoniker: RuntimeMoniker.Net70)]
[Config(typeof(Config))]
public class StringLiteralsBenchmark
{
    private sealed class Config : ManualConfig
    {
        public Config()
        {
            HideColumns("Job", "Error", "Median", "StdDev", "RatioSD");
        }
    }

    [Benchmark]
    public void PlusOperator()
    {
        _ = "Put aside your clever schemes!" +
            "O lover, be mindless! Become mad!" +
            "Dive into the heart of the flame!" +
            "Become fearless! Be like a moth!" +
            "" +
            "Turn away from the self" +
            "and tear down the house!" +
            "Then, come and dwell in the house of love!" +
            "Be a lover! Live with lovers!" +
            "" +
            "Clean your chest from all hostility." +
            "Wash it seven times." +
            "Then, fill it with the wine of love!" +
            "Be a chalice for love! Be a chalice!" +
            "" +
            "You must be all love" +
            "to be worthy of the beloved." +
            "When going to the gathering of drunks," +
            "be a drunk! Become drunk!" +
            "" +
            "Rumi – Divan of Shams – Poem 2131";

    }

    [Benchmark]
    public void OneLineHardToRead()
    {
        _ = "Put aside your clever schemes!\r\nO lover, be mindless! Become mad!\r\nDive into the heart of the flame!\r\nBecome fearless! Be like a moth!\r\n\r\nTurn away from the self\r\nand tear down the house!\r\nThen, come and dwell in the house of love!\r\nBe a lover! Live with lovers!\r\n\r\nClean your chest from all hostility.\r\nWash it seven times.\r\nThen, fill it with the wine of love!\r\nBe a chalice for love! Be a chalice!\r\n\r\nYou must be all love\r\nto be worthy of the beloved.\r\nWhen going to the gathering of drunks,\r\nbe a drunk! Become drunk!\r\n\r\nRumi – Divan of Shams – Poem 2131";
    }

    [Benchmark]
    public void RawStringLiterals()
    {
        _ = """
             Put aside your clever schemes!
             O lover, be mindless! Become mad!
             Dive into the heart of the flame!
             Become fearless! Be like a moth!

             Turn away from the self
             and tear down the house!
             Then, come and dwell in the house of love!
             Be a lover! Live with lovers!

             Clean your chest from all hostility.
             Wash it seven times.
             Then, fill it with the wine of love!
             Be a chalice for love! Be a chalice!

             You must be all love
             to be worthy of the beloved.
             When going to the gathering of drunks,
             be a drunk! Become drunk!

             Rumi – Divan of Shams – Poem 2131
             """;
    }

    [Benchmark(Baseline = true)]
    public void StringJoin()
    {
        _ = string.Join(Environment.NewLine,
                        "Put aside your clever schemes!",
                        "O lover, be mindless! Become mad!",
                        "Dive into the heart of the flame!",
                        "Become fearless! Be like a moth!",
                        "",
                        "Turn away from the self",
                        "and tear down the house!",
                        "Then, come and dwell in the house of love!",
                        "Be a lover! Live with lovers!",
                        "",
                        "Clean your chest from all hostility.",
                        "Wash it seven times.",
                        "Then, fill it with the wine of love!",
                        "Be a chalice for love! Be a chalice!",
                        "",
                        "You must be all love",
                        "to be worthy of the beloved.",
                        "When going to the gathering of drunks,",
                        "be a drunk! Become drunk!",
                        "",
                        "Rumi – Divan of Shams – Poem 2131");
    }

    [Benchmark]
    public void StringConcat()
    {
        _ = string.Concat("Put aside your clever schemes!", Environment.NewLine,
                          "O lover, be mindless! Become mad!", Environment.NewLine,
                          "Dive into the heart of the flame!", Environment.NewLine,
                          "Become fearless! Be like a moth!", Environment.NewLine,
                          Environment.NewLine,
                          "Turn away from the self", Environment.NewLine,
                          "and tear down the house!", Environment.NewLine,
                          "Then, come and dwell in the house of love!", Environment.NewLine,
                          "Be a lover! Live with lovers!", Environment.NewLine,
                          Environment.NewLine,
                          "Clean your chest from all hostility.", Environment.NewLine,
                          "Wash it seven times.", Environment.NewLine,
                          "Then, fill it with the wine of love!", Environment.NewLine,
                          "Be a chalice for love! Be a chalice!", Environment.NewLine,
                          Environment.NewLine,
                          "You must be all love", Environment.NewLine,
                          "to be worthy of the beloved.", Environment.NewLine,
                          "When going to the gathering of drunks,", Environment.NewLine,
                          "be a drunk! Become drunk!", Environment.NewLine,
                          Environment.NewLine,
                          "Rumi – Divan of Shams – Poem 2131");
    }
}
