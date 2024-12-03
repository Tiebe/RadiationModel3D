using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium116m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium116m";
        public override double halfLife { get; } = 3257.4d;
        public override double atomicWeight { get; } = 115.9054d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin116()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.00023744d, new GammaParticle(99730.0, 0.01243)), new(0.00050032d, new GammaParticle(116500.0, 0.01064)), new(0.00010175999999999999d, new GammaParticle(124650.0, 0.00995)), new(0.0369728d, new GammaParticle(138290.0, 0.00897)), new(0.0007038400000000001d, new GammaParticle(162600.0, 0.00763)), new(0.00015264d, new GammaParticle(163400.0, 0.00759)), new(0.00013568d, new GammaParticle(165720.0, 0.00748)), new(0.00050032d, new GammaParticle(196500.0, 0.00631)), new(0.00033071999999999995d, new GammaParticle(244980.0, 0.00506)), new(0.00125504d, new GammaParticle(263030.0, 0.00471)), new(0.0003816d, new GammaParticle(271960.0, 0.00456)), new(0.00079712d, new GammaParticle(272400.0, 0.00455)), new(0.00129744d, new GammaParticle(278620.0, 0.00445)), new(0.00120416d, new GammaParticle(303730.0, 0.00408)), new(0.0002968d, new GammaParticle(345200.0, 0.00359)), new(0.00730128d, new GammaParticle(355400.0, 0.00349)), new(6.784e-05d, new GammaParticle(395640.0, 0.00313)), new(0.00060208d, new GammaParticle(410230.0, 0.00302)), new(0.272208d, new GammaParticle(416900.0, 0.00297)), new(0.00022896d, new GammaParticle(435180.0, 0.00285)), new(0.0007038400000000001d, new GammaParticle(458500.0, 0.0027)), new(0.007250400000000001d, new GammaParticle(463210.0, 0.00268)), new(0.0001696d, new GammaParticle(474900.0, 0.00261)), new(0.0002968d, new GammaParticle(500100.0, 0.00248)), new(0.0001272d, new GammaParticle(517230.0, 0.0024)), new(0.0003392d, new GammaParticle(535030.0, 0.00232)), new(0.00054272d, new GammaParticle(567550.0, 0.00218)), new(0.0002968d, new GammaParticle(639100.0, 0.00194)), new(0.0012296d, new GammaParticle(655170.0, 0.00189)), new(0.00020351999999999998d, new GammaParticle(679850.0, 0.00182)), new(0.00166208d, new GammaParticle(688930.0, 0.0018)), new(0.00160272d, new GammaParticle(705970.0, 0.00176)), new(0.0006784d, new GammaParticle(730700.0, 0.0017)), new(2.968e-05d, new GammaParticle(736000.0, 0.00168)), new(0.00246768d, new GammaParticle(779120.0, 0.00159)), new(0.121264d, new GammaParticle(818680.0, 0.00151)), new(0.00028832d, new GammaParticle(830680.0, 0.00149)), new(0.0008988799999999999d, new GammaParticle(931830.0, 0.00133)), new(0.0049608000000000005d, new GammaParticle(972600.0, 0.00127)), new(0.00016112d, new GammaParticle(1072500.0, 0.00116)), new(0.58512d, new GammaParticle(1097280.0, 0.00113)), new(5.0879999999999994e-05d, new GammaParticle(1235490.0, 0.001)), new(0.00039856d, new GammaParticle(1254100.0, 0.00099)), new(0.848d, new GammaParticle(1293560.0, 0.00096)), new(7.8864e-05d, new GammaParticle(1356360.0, 0.00091)), new(0.099216d, new GammaParticle(1507590.0, 0.00082)), new(0.0235744d, new GammaParticle(1752500.0, 0.00071)), new(8.904e-05d, new GammaParticle(1803430.0, 0.00069)), new(0.150944d, new GammaParticle(2112290.0, 0.00059)), new(0.0004664d, new GammaParticle(2225390.0, 0.00056)), new(3.0528e-05d, new GammaParticle(2265690.0, 0.00055)), new(0.001096786087819616d, new GammaParticle(3753.0, 0.33036)), new(0.0034717708022971067d, new GammaParticle(25044.0, 0.04951)), new(0.006497793004486443d, new GammaParticle(25271.0, 0.04906)), new(0.0018373314751682964d, new GammaParticle(28579.0, 0.04338)), new(0.002199285775776451d, new GammaParticle(28810.0, 0.04304)), new(0.0003619543006081544d, new GammaParticle(29107.0, 0.0426)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    