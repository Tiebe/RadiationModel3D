using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium220 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium220";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 220.03272d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Protactinium216() }, { 1.0d, new AlphaParticle(11253002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    