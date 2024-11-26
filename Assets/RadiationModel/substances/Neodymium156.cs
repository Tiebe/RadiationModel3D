using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium156 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium156";
        public override double halfLife { get; } = 5.26d;
        public override double atomicWeight { get; } = 155.93537d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Promethium156() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    