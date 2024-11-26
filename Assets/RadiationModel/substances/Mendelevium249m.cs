using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium249m : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium249m";
        public override double halfLife { get; } = 24.8d;
        public override double atomicWeight { get; } = 249.08296d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.75d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Einsteinium245() }, { 1.0d, new AlphaParticle(9557002.09) } } },
            { 0.25d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Einsteinium249() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
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
    