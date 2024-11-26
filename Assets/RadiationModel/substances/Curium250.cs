using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium250 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium250";
        public override double halfLife { get; } = 261922485589.1136d;
        public override double atomicWeight { get; } = 250.07836d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.74d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.18d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Plutonium246() }, { 1.0d, new AlphaParticle(6192002.09) } } },
            { 0.08d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Berkelium250() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    