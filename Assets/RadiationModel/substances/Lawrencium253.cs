using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium253 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium253";
        public override double halfLife { get; } = 0.57d;
        public override double atomicWeight { get; } = 253.09503d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.987d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mendelevium249() }, { 1.0d, new AlphaParticle(9937002.09) } } },
            { 0.013000000000000001d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    