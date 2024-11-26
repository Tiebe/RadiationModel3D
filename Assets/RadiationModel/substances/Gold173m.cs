using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold173m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold173m";
        public override double halfLife { get; } = 0.0122d;
        public override double atomicWeight { get; } = 172.98645d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.92d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium169() }, { 1.0d, new AlphaParticle(8072002.09) } } },
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
    