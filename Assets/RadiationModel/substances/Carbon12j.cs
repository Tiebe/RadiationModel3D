using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon12j : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon12j";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 12.02962d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.27399999999999997d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Boron11() }, { 1.0d, new ProtonParticle() } } },
            { 0.196d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Beryllium8() }, { 1.0d, new AlphaParticle(21250332.09) } } },
            { 0.027999999999999997d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    