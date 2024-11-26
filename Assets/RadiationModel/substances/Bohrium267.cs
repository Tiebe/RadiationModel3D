using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bohrium267 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium267";
        public override double halfLife { get; } = 14.0d;
        public override double atomicWeight { get; } = 267.1275d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dubnium263() }, { 1.0d, new AlphaParticle(10257002.09) } } },
            { 0.08d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    