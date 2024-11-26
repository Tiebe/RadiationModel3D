using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead213 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead213";
        public override double halfLife { get; } = 612.0d;
        public override double atomicWeight { get; } = 212.99656d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth213()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.154d, new GammaParticle(257700.0, 0.00481)), new(0.00616d, new GammaParticle(274300.0, 0.00452)), new(0.018942d, new GammaParticle(302700.0, 0.0041)), new(0.01463d, new GammaParticle(324200.0, 0.00382)), new(0.004928d, new GammaParticle(334900.0, 0.0037)), new(0.00616d, new GammaParticle(592900.0, 0.00209)), new(0.09548d, new GammaParticle(720300.0, 0.00172)), new(0.041580000000000006d, new GammaParticle(874300.0, 0.00142)), new(0.010471999999999999d, new GammaParticle(893100.0, 0.00139)), new(0.004928d, new GammaParticle(913800.0, 0.00136)), new(0.011242d, new GammaParticle(944500.0, 0.00131)), new(0.04003999999999999d, new GammaParticle(964700.0, 0.00129)), new(0.17094d, new GammaParticle(977500.0, 0.00127)), new(0.02618d, new GammaParticle(982900.0, 0.00126)), new(0.007391999999999999d, new GammaParticle(1029600.0, 0.0012)), new(0.025718d, new GammaParticle(1037700.0, 0.00119)), new(0.007084d, new GammaParticle(1085500.0, 0.00114)), new(0.0616d, new GammaParticle(1142400.0, 0.00109)), new(0.010626d, new GammaParticle(1149300.0, 0.00108)), new(0.09394d, new GammaParticle(1171000.0, 0.00106)), new(0.06314d, new GammaParticle(1187000.0, 0.00104)), new(0.012627999999999999d, new GammaParticle(1237400.0, 0.001)), new(0.010471999999999999d, new GammaParticle(1285500.0, 0.00096)), new(0.006468000000000001d, new GammaParticle(1335500.0, 0.00093)), new(0.01155d, new GammaParticle(1445400.0, 0.00086)), new(0.013244d, new GammaParticle(1592100.0, 0.00078)), new(0.02131394958d, new GammaParticle(12904.0, 0.09608)), new(0.014318243557144646d, new GammaParticle(74815.0, 0.01657)), new(0.023955568942855353d, new GammaParticle(77108.0, 0.01608)), new(0.008205717840735068d, new GammaParticle(87388.0, 0.01419)), new(0.010716667499999999d, new GammaParticle(88458.0, 0.01402)), new(0.0025109496592649306d, new GammaParticle(89784.0, 0.01381)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    