using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth191m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth191m";
        public override double halfLife { get; } = 0.125d;
        public override double atomicWeight { get; } = 190.98605d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.68d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium187() }, { 1.0d, new AlphaParticle(8045002.09) } } },
            { 0.32d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth191() } } },
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
    