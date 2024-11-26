using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium248 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium248";
        public override double halfLife { get; } = 10981810239158.016d;
        public override double atomicWeight { get; } = 248.07235d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9161d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Plutonium244() }, { 1.0d, new AlphaParticle(6183702.09) } } },
            { 0.0839d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    