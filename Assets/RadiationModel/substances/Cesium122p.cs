using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cesium122p : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium122p";
        public override double halfLife { get; } = 0.36d;
        public override double atomicWeight { get; } = 121.91625d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cesium122()), new(0.01664d, new GammaParticle(45850.0, 0.02704)), new(0.047008d, new GammaParticle(81200.0, 0.01527)), new(0.1332361691648d, new GammaParticle(4749.0, 0.26107)), new(0.22376243911147614d, new GammaParticle(30625.0, 0.04048)), new(0.41337971385826d, new GammaParticle(30973.0, 0.04003)), new(0.12077019266098374d, new GammaParticle(35089.0, 0.03533)), new(0.15023811967026376d, new GammaParticle(35414.0, 0.03501)), new(0.02946792700928003d, new GammaParticle(35818.0, 0.03462)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    