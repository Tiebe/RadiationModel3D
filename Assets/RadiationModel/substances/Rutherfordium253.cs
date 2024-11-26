using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium253 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium253";
        public override double halfLife { get; } = 0.0099d;
        public override double atomicWeight { get; } = 253.10053d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.83d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.17d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nobelium249() }, { 1.0d, new AlphaParticle(10447002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    