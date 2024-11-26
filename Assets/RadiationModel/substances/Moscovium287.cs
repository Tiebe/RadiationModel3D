using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Moscovium287 : RadioactiveSubstance
    {
        public override string name { get; } = "Moscovium287";
        public override double halfLife { get; } = 0.037d;
        public override double atomicWeight { get; } = 287.19082d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nihonium283() }, { 1.0d, new AlphaParticle(11787002.09) } } },
            { 0.25d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    