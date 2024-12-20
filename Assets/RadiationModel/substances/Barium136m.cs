using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Barium136m : RadioactiveSubstance
    {
        public override string name { get; } = "Barium136m";
        public override double halfLife { get; } = 0.3084d;
        public override double atomicWeight { get; } = 135.90676d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Barium136()), new(0.3125d, new GammaParticle(163920.0, 0.00756)), new(0.00024d, new GammaParticle(315500.0, 0.00393)), new(0.00012d, new GammaParticle(732410.0, 0.00169)), new(0.9970600000000001d, new GammaParticle(818514.0, 0.00151)), new(0.9982d, new GammaParticle(1048073.0, 0.00118)), new(0.00013d, new GammaParticle(1550990.0, 0.0008)), new(0.064413661083354d, new GammaParticle(4966.0, 0.24967)), new(0.08916891962814731d, new GammaParticle(31816.0, 0.03897)), new(0.16427582834957127d, new GammaParticle(32193.0, 0.03851)), new(0.048320496279777504d, new GammaParticle(36482.0, 0.03399)), new(0.06049726134228143d, new GammaParticle(36827.0, 0.03367)), new(0.01217676506250393d, new GammaParticle(37255.0, 0.03328)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    