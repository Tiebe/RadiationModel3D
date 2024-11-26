using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium139 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium139";
        public override double halfLife { get; } = 1.6d;
        public override double atomicWeight { get; } = 138.93537d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine139() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
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
    