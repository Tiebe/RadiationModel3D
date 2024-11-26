using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium254 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium254";
        public override double halfLife { get; } = 51.2d;
        public override double atomicWeight { get; } = 254.09095d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fermium250() }, { 1.0d, new AlphaParticle(9248002.09) } } },
            { 0.1d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mendelevium254() } } },
            { 0.0017000000000000001d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    