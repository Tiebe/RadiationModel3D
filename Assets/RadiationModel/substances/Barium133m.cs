using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium133m : RadioactiveSubstance
    {
        public override string name { get; } = "Barium133m";
        public override double halfLife { get; } = 140148.0d;
        public override double atomicWeight { get; } = 132.90632d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.999896d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Barium133()), new(0.014199999999999999d, new GammaParticle(12327.0, 0.10058)), new(0.177d, new GammaParticle(275925.0, 0.00449)), new(3.1799999999999996e-06d, new GammaParticle(288000.0, 0.00431)), new(0.166d, new GammaParticle(4966.0, 0.24967)), new(0.156d, new GammaParticle(31816.0, 0.03897)), new(0.28800000000000003d, new GammaParticle(32193.0, 0.03851)), new(0.085d, new GammaParticle(36482.0, 0.03399)), new(0.106d, new GammaParticle(36827.0, 0.03367)), new(0.0213d, new GammaParticle(37255.0, 0.03328)) } },
            { 0.000104d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cesium133()), new(0.000103d, new GammaParticle(632590.0, 0.00196)), new(9.3742008152e-06d, new GammaParticle(4749.0, 0.26107)), new(2.0976077261936436e-05d, new GammaParticle(30625.0, 0.04048)), new(3.875129736178909e-05d, new GammaParticle(30973.0, 0.04003)), new(1.1321314257455369e-05d, new GammaParticle(35089.0, 0.03533)), new(1.4083714936274477e-05d, new GammaParticle(35414.0, 0.03501)), new(2.7624006788191106e-06d, new GammaParticle(35818.0, 0.03462)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    