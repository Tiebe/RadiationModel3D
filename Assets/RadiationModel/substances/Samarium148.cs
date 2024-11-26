using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium148 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium148";
        public override double halfLife { get; } = 2.20898481822144e+23d;
        public override double atomicWeight { get; } = 147.91483d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium144() }, { 1.0d, new AlphaParticle(3008902.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    