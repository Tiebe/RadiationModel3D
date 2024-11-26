using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon12i : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon12i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 12.01622d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9590000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Carbon12() } } },
            { 0.040999999999999995d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Beryllium8() }, { 1.0d, new AlphaParticle(8763332.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    