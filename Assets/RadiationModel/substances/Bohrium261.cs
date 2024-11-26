using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bohrium261 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium261";
        public override double halfLife { get; } = 0.012d;
        public override double atomicWeight { get; } = 261.1214d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.95d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dubnium257() }, { 1.0d, new AlphaParticle(11527002.09) } } },
            { 0.1d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    