using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cesium127m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium127m";
        public override double halfLife { get; } = 6e-05d;
        public override double atomicWeight { get; } = 126.9079d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cesium127()), new(0.114d, new GammaParticle(65900.0, 0.01881)), new(0.055999999999999994d, new GammaParticle(72900.0, 0.01701)), new(0.094d, new GammaParticle(133700.0, 0.00927)), new(0.024d, new GammaParticle(139000.0, 0.00892)), new(0.42100000000000004d, new GammaParticle(178800.0, 0.00693)), new(0.585d, new GammaParticle(206000.0, 0.00602)), new(0.1d, new GammaParticle(385500.0, 0.00322)), new(0.15098306834d, new GammaParticle(4749.0, 0.26107)), new(0.2700314825582833d, new GammaParticle(30625.0, 0.04048)), new(0.4988573481586612d, new GammaParticle(30973.0, 0.04003)), new(0.14574275424682917d, new GammaParticle(35089.0, 0.03533)), new(0.1813039862830555d, new GammaParticle(35414.0, 0.03501)), new(0.03556123203622632d, new GammaParticle(35818.0, 0.03462)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    