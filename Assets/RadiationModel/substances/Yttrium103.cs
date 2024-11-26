using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium103 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium103";
        public override double halfLife { get; } = 0.23d;
        public override double atomicWeight { get; } = 102.93724d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium103() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) }, { 0.12d, new GammaParticle(98200.0, 0.01263) }, { 0.08d, new GammaParticle(109100.0, 0.01136) }, { 0.08d, new GammaParticle(248000.0, 0.005) } } },
            { 0.08d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium103() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) }, { 0.12d, new GammaParticle(98200.0, 0.01263) }, { 0.08d, new GammaParticle(109100.0, 0.01136) }, { 0.08d, new GammaParticle(248000.0, 0.005) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    