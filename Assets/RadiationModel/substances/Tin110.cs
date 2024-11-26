using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin110 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin110";
        public override double halfLife { get; } = 14954.4d;
        public override double atomicWeight { get; } = 109.90784d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Indium110()), new(0.9706d, new GammaParticle(280459.0, 0.00442)), new(0.06480473518886401d, new GammaParticle(3571.0, 0.3472)), new(0.21055680231101245d, new GammaParticle(24001.0, 0.05166)), new(0.39504090489871d, new GammaParticle(24209.0, 0.05121)), new(0.11083964758846854d, new GammaParticle(27367.0, 0.0453)), new(0.13189918063027756d, new GammaParticle(27581.0, 0.04495)), new(0.021059533041809023d, new GammaParticle(27858.0, 0.04451)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    