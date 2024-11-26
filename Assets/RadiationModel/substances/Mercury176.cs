using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury176 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury176";
        public override double halfLife { get; } = 0.0203d;
        public override double atomicWeight { get; } = 175.98735d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.94d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum172() }, { 1.0d, new AlphaParticle(7919002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    