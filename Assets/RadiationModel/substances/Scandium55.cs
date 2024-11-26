using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium55 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium55";
        public override double halfLife { get; } = 0.096d;
        public override double atomicWeight { get; } = 54.96689d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium55() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) }, { 0.02d, new GammaParticle(349600.0, 0.00355) }, { 0.83d, new GammaParticle(591700.0, 0.0021) }, { 0.11d, new GammaParticle(712300.0, 0.00174) }, { 0.35d, new GammaParticle(1203800.0, 0.00103) }, { 0.09d, new GammaParticle(1554100.0, 0.0008) } } },
            { 0.17d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium55() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) }, { 0.02d, new GammaParticle(349600.0, 0.00355) }, { 0.83d, new GammaParticle(591700.0, 0.0021) }, { 0.11d, new GammaParticle(712300.0, 0.00174) }, { 0.35d, new GammaParticle(1203800.0, 0.00103) }, { 0.09d, new GammaParticle(1554100.0, 0.0008) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    