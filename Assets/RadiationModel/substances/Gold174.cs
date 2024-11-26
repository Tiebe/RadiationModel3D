using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold174 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold174";
        public override double halfLife { get; } = 0.12d;
        public override double atomicWeight { get; } = 173.98491d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium170() }, { 1.0d, new AlphaParticle(7717002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    