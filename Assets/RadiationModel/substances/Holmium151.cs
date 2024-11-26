using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium151";
        public override double halfLife { get; } = 35.2d;
        public override double atomicWeight { get; } = 150.9317d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.78d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium151() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.22d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium147() }, { 1.0d, new AlphaParticle(5717002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    