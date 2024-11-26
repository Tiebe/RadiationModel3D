using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium220 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium220";
        public override double halfLife { get; } = 0.018d;
        public override double atomicWeight { get; } = 220.01103d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon216()), new(1.0d, new AlphaParticle(8616002.09)), new(0.01d, new GammaParticle(465000.0, 0.00267)), new(0.000140551776d, new GammaParticle(14088.0, 0.08801)), new(7.753580565968352e-05d, new GammaParticle(81070.0, 0.01529)), new(0.00012790466126638654d, new GammaParticle(83789.0, 0.0148)), new(4.4356464449946933e-05d, new GammaParticle(94878.0, 0.01307)), new(5.855053307392996e-05d, new GammaParticle(96054.0, 0.01291)), new(1.4194068623983019e-05d, new GammaParticle(97530.0, 0.01271)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    