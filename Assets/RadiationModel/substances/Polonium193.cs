using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium193 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium193";
        public override double halfLife { get; } = 0.399d;
        public override double atomicWeight { get; } = 192.99106d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead189() }, { 1.0d, new AlphaParticle(8116002.09) }, { 0.72d, new GammaParticle(549000.0, 0.00226) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    