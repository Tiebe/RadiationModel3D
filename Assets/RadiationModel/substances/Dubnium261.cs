using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium261 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium261";
        public override double halfLife { get; } = 1.8d;
        public override double atomicWeight { get; } = 261.11198d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.82d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lawrencium257() }, { 1.0d, new AlphaParticle(10237002.09) } } },
            { 0.18d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    