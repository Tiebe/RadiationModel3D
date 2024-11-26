using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium245 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium245";
        public override double halfLife { get; } = 5.6d;
        public override double atomicWeight { get; } = 245.07535d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Californium241() }, { 1.0d, new AlphaParticle(9457002.09) } } },
            { 0.115d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Californium245() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.003d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    