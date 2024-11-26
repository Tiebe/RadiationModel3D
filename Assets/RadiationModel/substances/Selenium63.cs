using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium63 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium63";
        public override double halfLife { get; } = 0.0132d;
        public override double atomicWeight { get; } = 62.98191d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium63() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.89d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium62() }, { 1.0d, new ProtonParticle() } } },
            { 0.005d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium61() }, { 1.0d, new ProtonParticle() } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    