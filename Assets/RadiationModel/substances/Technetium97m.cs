using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium97m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium97m";
        public override double halfLife { get; } = 7862400.0d;
        public override double atomicWeight { get; } = 96.90647d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9606d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Technetium97()), new(0.003205d, new GammaParticle(96500.0, 0.01285)), new(0.038819302935d, new GammaParticle(2586.0, 0.47944)), new(0.14160612860563881d, new GammaParticle(18250.0, 0.06794)), new(0.2692643631976399d, new GammaParticle(18367.0, 0.0675)), new(0.07156526614570062d, new GammaParticle(20695.0, 0.05991)), new(0.08287257819672131d, new GammaParticle(20820.0, 0.05955)), new(0.011307312051020696d, new GammaParticle(21003.0, 0.05903)) } },
            { 0.0394d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Molybdenum97()), new(5.8992531621e-05d, new GammaParticle(2440.0, 0.50813)), new(0.00029416157516567033d, new GammaParticle(17374.0, 0.07136)), new(0.000560628121146694d, new GammaParticle(17479.0, 0.07093)), new(0.00014710678829084537d, new GammaParticle(19681.0, 0.063)), new(0.00016976123368763553d, new GammaParticle(19794.0, 0.06264)), new(2.2654445396790186e-05d, new GammaParticle(19963.0, 0.06211)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    