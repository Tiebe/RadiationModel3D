using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium169m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium169m";
        public override double halfLife { get; } = 0.281d;
        public override double atomicWeight { get; } = 168.97645d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.72d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium165() }, { 1.0d, new AlphaParticle(7316002.09) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
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
    