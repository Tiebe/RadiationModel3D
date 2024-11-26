using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium244 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium244";
        public override double halfLife { get; } = 0.38d;
        public override double atomicWeight { get; } = 244.08116d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Einsteinium240() }, { 1.0d, new AlphaParticle(9967002.09) } } },
            { 0.14d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Einsteinium244() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    