using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium254 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium254";
        public override double halfLife { get; } = 18.1d;
        public override double atomicWeight { get; } = 254.09624d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.7170000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mendelevium250() }, { 1.0d, new AlphaParticle(9847002.09) } } },
            { 0.28300000000000003d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mendelevium254() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.001d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    