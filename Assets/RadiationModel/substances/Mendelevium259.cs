using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium259 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium259";
        public override double halfLife { get; } = 5760.0d;
        public override double atomicWeight { get; } = 259.10044d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.013000000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Einsteinium255() }, { 1.0d, new AlphaParticle(8068002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    