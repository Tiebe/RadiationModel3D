using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium257 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium257";
        public override double halfLife { get; } = 2.3d;
        public override double atomicWeight { get; } = 257.10752d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.94d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lawrencium253() }, { 1.0d, new AlphaParticle(10227002.09) } } },
            { 0.06d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    