using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth192m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth192m";
        public override double halfLife { get; } = 39.6d;
        public override double atomicWeight { get; } = 191.98562d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium192() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.1d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium188() }, { 1.0d, new AlphaParticle(7535002.09) }, { 0.0023d, new GammaParticle(33600.0, 0.0369) }, { 6e-05d, new GammaParticle(103100.0, 0.01203) }, { 0.09d, new GammaParticle(268800.0, 0.00461) }, { 0.0811917585032d, new GammaParticle(12148.0, 0.10206) }, { 0.04053156553680885d, new GammaParticle(70832.0, 0.0175) }, { 0.06841925310062263d, new GammaParticle(72874.0, 0.01701) }, { 0.02326860197576602d, new GammaParticle(82629.0, 0.015) }, { 0.030179376762568526d, new GammaParticle(83631.0, 0.01483) }, { 0.006910774786802508d, new GammaParticle(84866.0, 0.01461) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    