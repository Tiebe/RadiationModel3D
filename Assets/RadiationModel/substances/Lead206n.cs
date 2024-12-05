using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead206n : RadioactiveSubstance
    {
        public override string name { get; } = "Lead206n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 205.97879d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead206()), new(0.01122d, new GammaParticle(69700.0, 0.01779)), new(0.9570000000000001d, new GammaParticle(458100.0, 0.00271)), new(0.3762d, new GammaParticle(1299100.0, 0.00095)), new(0.561d, new GammaParticle(1369000.0, 0.00091)), new(0.11362459888764599d, new GammaParticle(12522.0, 0.09901)), new(0.00783957672260117d, new GammaParticle(72805.0, 0.01703)), new(0.013175759197649026d, new GammaParticle(74970.0, 0.01654)), new(0.004503286268625041d, new GammaParticle(84986.0, 0.01459)), new(0.0058632787217498036d, new GammaParticle(86022.0, 0.01441)), new(0.0013599924531247625d, new GammaParticle(87301.0, 0.0142)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    