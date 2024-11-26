using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copernicium282 : RadioactiveSubstance
    {
        public override string name { get; } = "Copernicium282";
        public override double halfLife { get; } = 0.00096d;
        public override double atomicWeight { get; } = 282.17051d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.07d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new AlphaParticle(259112787767.30002) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    