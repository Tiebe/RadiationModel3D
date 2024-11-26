using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copernicium277 : RadioactiveSubstance
    {
        public override string name { get; } = "Copernicium277";
        public override double halfLife { get; } = 0.00061d;
        public override double atomicWeight { get; } = 277.16353d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Darmstadtium273() }, { 1.0d, new AlphaParticle(12637002.09) } } },
            { 0.17d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    