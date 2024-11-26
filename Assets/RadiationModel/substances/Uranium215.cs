using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium215 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium215";
        public override double halfLife { get; } = 0.0007d;
        public override double atomicWeight { get; } = 215.02672d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thorium211() }, { 1.0d, new AlphaParticle(9607002.09) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    