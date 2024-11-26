using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium251 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium251";
        public override double halfLife { get; } = 0.8d;
        public override double atomicWeight { get; } = 251.08894d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.91d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fermium247() }, { 1.0d, new AlphaParticle(9777002.09) } } },
            { 1.4e-05d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fermium251() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    